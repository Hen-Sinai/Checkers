using System.Drawing;
using System.Windows.Forms;
using GameLogic;

namespace UI
{
    class CellButton : Button
    {
        private Image m_OriginImage;
        private readonly int r_Row;
        private readonly int r_Col;

        public CellButton(Location i_Location, int i_Size, int i_Row, int i_Col)
        {
            this.Location = new Point(i_Location.Col, i_Location.Row);
            this.Height = this.Width = i_Size;
            r_Row = i_Row;
            r_Col = i_Col;
        }

        public Image OriginImage
        {
            get
            {
                return m_OriginImage;
            }

            set
            {
                m_OriginImage = value;
            }
        }

        public int Row
        {
            get
            {
                return r_Row;
            }
        }

        public int Col
        {
            get
            {
                return r_Col;
            }
        }
    }
}
