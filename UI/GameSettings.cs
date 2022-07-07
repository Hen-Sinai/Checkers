namespace UI
{
    public class GameSettings
    {
        private string m_Player1Name;
        private string m_Player2Name = "Computer";
        private eBoardSize m_BoardSize = eBoardSize.Small;
        private bool m_IsAi = true;

        public string Player1Name
        {
            get
            {
                return m_Player1Name;
            }

            set
            {
                m_Player1Name = value;
            }
        }

        public string Player2Name
        {
            get
            {
                return m_Player2Name;
            }

            set
            {
                m_Player2Name = value;
            }
        }

        public eBoardSize BoardSize
        {
            get
            {
                return m_BoardSize;
            }

            set
            {
                m_BoardSize = value;
            }
        }

        public bool isAi
        {
            get
            {
                return m_IsAi;
            }

            set
            {
                m_IsAi = value;
            }
        }
    }
}
