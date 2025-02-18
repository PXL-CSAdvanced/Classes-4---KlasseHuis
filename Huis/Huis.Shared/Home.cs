using System.Text;

namespace Huis.Shared
{
    public class Home
    {
        #region Variables & Properties
        private string _location;

		public string Location
		{
			get { return _location; }
			set { _location = value; }
		}

		private double _length;

		public double Length
		{
			get { return _length; }
			set { _length = value; }
		}

		private double _width;

		public double Width
		{
			get { return _width; }
			set { _width = value; }
		}

		private int _numberOfFloors;

		public int NumberOfFloors
		{
			get { return _numberOfFloors; }
			set 
			{ 
				_numberOfFloors = value; 

				if(_numberOfFloors < 1)
				{
					_numberOfFloors = 1;
				}
			}
		}

		private char _type;

		public char Type
		{
			get { return _type; }
			set { _type = value; }
		}

		public string TypeDescription
		{
			get 
			{ 
				switch(this.Type)
				{
					case 'O':
						return "Open bebouwing";
					case 'H':
						return "Halfopen bebouwing";
					case 'G':
						return "Gesloten bebouwing";
					default:
						return string.Empty;
				}
			}
		}
		#endregion

		#region Constructors
		public Home()
        {
			_location = string.Empty;
			_length = 0;
			_width = 0;
			_numberOfFloors = 1;
			_type = 'O';
        }

        public Home(string location, double length, double width, uint floors, char type)
        {
			_location = location;
			_length = length;
			_width = width;
			this.NumberOfFloors = Convert.ToInt32(floors);
			_type = type;
        }
        #endregion

        #region Methods & Functions
		public void IncreaseNumberOfFloors(int floors = 1)
		{
			this.NumberOfFloors += floors;
		}

        public void DecreaseNumberOfFloors(int floors = 1)
        {
			this.NumberOfFloors -= floors;
        }

		public double GetSurface()
		{
			return this.Length * this.Width;
		}

		public double GetVolume()
		{
			return this.Length * this.Width * (2.5 * this.NumberOfFloors);
		}

		public string GetDescription()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine(this.Location);
			sb.AppendLine(this.TypeDescription);
			sb.AppendLine("Lengte: " + this.Length.ToString("N2"));
            sb.AppendLine("Breedte: " + this.Width.ToString("N2"));
            sb.AppendLine("Verdiepingen: " + this.NumberOfFloors.ToString());
			sb.AppendLine("Oppervlakte: " + this.GetSurface().ToString("N2") + "m²");
			sb.AppendLine("Inhoud: " + this.GetVolume().ToString("N2") + "m³");

			return sb.ToString();
        }
        #endregion
    }
}
