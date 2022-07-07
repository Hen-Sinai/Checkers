namespace GameLogic
{
    public struct Cell
    {
        private Location m_Location;
        private eObjectInCell m_CellObject;

        public Location Location
        {
            get
            {
                return m_Location;
            }

            set
            {
                m_Location = value;
            }
        }

        public eObjectInCell CellObject
        {
            get
            {
                return m_CellObject;
            }

            set
            {
                m_CellObject = value;
            }
        }
    }

    
}
