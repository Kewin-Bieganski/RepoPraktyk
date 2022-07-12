namespace zbudujemyDom
{
    public partial class Form1 : Form
    {
        Location currentLocation;
        RoomWithDoor livingRoom;
        Room diningRoom;
        RoomWithDoor kitchen;
        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        Outside garden;

        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            MoveToANewLocation(livingRoom);
        }

        private void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Salon", "antyczny dywan", "d�bowe drzwi z mosi�n� klamk�");
            diningRoom = new Room("Jadalnia", "kryszta�owy �yrandol");
            kitchen = new RoomWithDoor("Kuchnia", "nierdzewne stalowe sztu�ce", "rozsuwane drzwi");

            frontYard = new OutsideWithDoor("Podw�rko przed domem", false, "d�bowe drzwi z mosi�n� klamk�");
            backYard = new OutsideWithDoor("Podw�rko za domem", true, "rozsuwane drzwi");
            garden = new Outside("Ogr�d", false);

            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            livingRoom.Exits = new Location[] { diningRoom };
            kitchen.Exits = new Location[] { diningRoom };
            frontYard.Exits = new Location[] { backYard, garden };
            backYard.Exits = new Location[] { frontYard, garden };
            garden.Exits = new Location[] { backYard, frontYard };

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;

            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
        }
        private void MoveToANewLocation(Location newLocation)
        {
            currentLocation = newLocation;
            
            cBox_locations.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++)
            {
                cBox_locations.Items.Add(currentLocation.Exits[i].Name);
            }
            cBox_locations.SelectedIndex = 0;
            rTB_output.Text = currentLocation.Description;
            b_goThroughTheDoor.Visible = (currentLocation is IHasExteriorDoor ? true : false);
        }

        private void b_goHere_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[cBox_locations.SelectedIndex]);
        }

        private void b_goThroughTheDoor_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasDoor.DoorLocation);
        }
    }
}