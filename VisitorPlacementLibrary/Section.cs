using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPlacementLibrary
{
    public class Section
    {
        private int MaxRows = 3;
        private int MinRows = 1;
        public string SectionLetter{ get; private set; }
        public int NumOfRows { get; private set; }
        public int NumOfSeats { get; private set; }

        private List<Row> Rows = new();
        public IReadOnlyList<Row> rows
        {
            get
            {
                return Rows;
            }
        }

        public Section(string sectionLetter, int numOfRows, int numOfSeats)
        { 
            SectionLetter = sectionLetter;
            NumOfRows = numOfRows;
            NumOfSeats = numOfSeats;
            if(numOfRows < MinRows)
            {
                throw new InvalidOperationException("Nummer van rijen kan niet onder minimaal zitten!");
            }

            if (numOfRows > MaxRows)
            {
                throw new InvalidOperationException("Nummer van rijen kan niet over het maximale zitten!");
            }

            AddRows();
        }

        public void AddRows()
        {
            for (int i = 0; i < NumOfRows; i++) {
                Rows.Add(new Row(SectionLetter + (i+1).ToString(), NumOfSeats));
            }
        }
    }
}
