namespace hideAndSeek
{
    public partial class Form1 : Form
    {
        int Moves;
        Location currentLocation;
        RoomWithDoor livingRoom;
        RoomWithHidingPlace diningRoom;
        RoomWithDoor kitchen;
        Room stairs;
        RoomWithHidingPlace hallway;
        RoomWithHidingPlace bathroom;
        RoomWithHidingPlace masterBedroom;
        RoomWithHidingPlace secondBedroom;
        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        OutsideWithHidingPlace garden;
        OutsideWithHidingPlace driveway;
        Opponent opponent;

        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            opponent = new Opponent(frontYard);
            ResetGame(false);
        }

        private void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Salon", "antyczny dywan", "w szafie �ciennej", "d�bowe drzwi z mosi�n� klamk�");
            diningRoom = new RoomWithHidingPlace("Jadalnia", "kryszta�owy �yrandol", "w wysokiej szafie");
            kitchen = new RoomWithDoor("Kuchnia", "nierdzewne stalowe sztu�ce", "w szafce", "rozsuwane drzwi");
            stairs = new Room("Schody", "drewniana por�cz");
            hallway = new RoomWithHidingPlace("Korytarz na g�rze", "Obrazek z psem", "w szafie �ciennej");
            bathroom = new RoomWithHidingPlace("�azienka", "umywalka i toaleta", "pod prysznicem");
            masterBedroom = new RoomWithHidingPlace("Du�a sypialnia", "du�e ��ko", "pod ��kiem");
            secondBedroom = new RoomWithHidingPlace("Druga sypialnia", "ma�e ��ko", "pod ��kiem");

            frontYard = new OutsideWithDoor("Podw�rko przed domem", false, "ci�kie d�bowe drzwi");
            backYard = new OutsideWithDoor("Podw�rko za domem", true, "rozsuwane drzwi");
            garden = new OutsideWithHidingPlace("Ogr�d", false, "w szopie");
            driveway = new OutsideWithHidingPlace("Droga dojazdowa", true, "w gara�u");

            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            livingRoom.Exits = new Location[] { diningRoom, stairs };
            kitchen.Exits = new Location[] { diningRoom };
            stairs.Exits = new Location[] { livingRoom, hallway };
            hallway.Exits = new Location[] { stairs, bathroom, masterBedroom, secondBedroom };
            bathroom.Exits = new Location[] { hallway };
            masterBedroom.Exits = new Location[] { hallway };
            secondBedroom.Exits = new Location[] { hallway };
            frontYard.Exits = new Location[] { backYard, garden, driveway };
            backYard.Exits = new Location[] { frontYard, garden, driveway };
            garden.Exits = new Location[] { backYard, frontYard };
            driveway.Exits = new Location[] { backYard, frontYard };

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;

            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
        }
        private void MoveToANewLocation(Location newLocation)
        {
            Moves++;
            currentLocation = newLocation;
            RedrawForm();
        }

        private void RedrawForm()
        {
            cBox_locations.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++)
            {
                cBox_locations.Items.Add(currentLocation.Exits[i].Name);
            }
            cBox_locations.SelectedIndex = 0;
            rTB_output.Text = $"{currentLocation.Description}\r\n(ruch numer {Moves})";
            if (currentLocation is IHidingPlace)
            {
                IHidingPlace hidingPlace = currentLocation as IHidingPlace;
                b_check.Text = $"Sprawd� {hidingPlace.HidingPlaceName}";
                b_check.Visible = true;
            }
            else
            {
                b_check.Visible = false;
            }
            if (currentLocation is IHasExteriorDoor)
            {
                b_goThroughTheDoor.Visible = true;
            }
            else
            {
                b_goThroughTheDoor.Visible = false;
            }
        }

        private void ResetGame(bool displayMessage)
        {
            if(displayMessage)
            {
                MessageBox.Show($"Odnalaz�e� mnie w {Moves} ruchach!");
                IHidingPlace foundLocation = currentLocation as IHidingPlace;
                rTB_output.Text = $"Znalaz�e� przeciwnika w {Moves} ruchach! Ukrywa� si� w {foundLocation.HidingPlaceName}.";
            }
            Moves = 0;
            b_hide.Visible = true;
            b_goHere.Visible = false;
            b_check.Visible = false;
            b_goThroughTheDoor.Visible = false;
            cBox_locations.Visible = false;
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

        private void b_hide_Click(object sender, EventArgs e)
        {
            b_hide.Visible = false;
            for (int i = 0; i < 10; i++)
            {
                opponent.Move();
                rTB_output.Text = $"{i}... ";
                Application.DoEvents();
                System.Threading.Thread.Sleep(200);
            }

            rTB_output.Text = $"Gotowy czy nie - nadchodz�!";
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);

            b_goHere.Visible = true;
            cBox_locations.Visible = true;
            MoveToANewLocation(livingRoom);
        }

        private void b_check_Click(object sender, EventArgs e)
        {
            Moves++;
            if (opponent.Check(currentLocation))
            {
                ResetGame(true);
            }
            else
            {
                RedrawForm();
            }
        }
    }
}