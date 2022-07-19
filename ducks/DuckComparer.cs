namespace ducks
{
    internal class DuckComparer : IComparer<Duck>
    {
        public enum SortCriteria
        {
            SizeThenKind,
            KindThenSize,
        }

        public SortCriteria SortBy;

        public int Compare(Duck? x, Duck? y)
        {
            if (SortBy == SortCriteria.SizeThenKind)
                if (x.Size > y.Size)
                    return 1;
                else if (x.Size < y.Size)
                    return -1;
                else
                    if (x.Kind > y.Kind)
                        return 1;
                    else if (x.Kind < y.Kind)
                        return -1;
                    else 
                        return 0;
            else
                if(x.Kind > y.Kind)
                    return 1;
                else if (x.Kind < y.Kind)
                    return -1;
                else
                    if (x.Size > y.Size)
                        return 1;
                    else if (x.Size < y.Size)
                        return -1;
                    return 0;
        }
    }
}
