using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTicket
{
    internal class PlaneTicket
    {
        private string _origin;
        private string _dest;
        private int _cost;
        private string _con;

        public string Origin
        {
            get // get accessor
            {
                return _origin;
            }
            set // set accessor
            {
                _origin = value;
            }
        }

        public string Destination
        {
            get // get accessor
            {
                return _dest;
            }
            set // set accessor
            {
                _dest = value;
            }
        }

        public int Cost
        {
            get // get accessor
            {
                return _cost;
            }
            set // set accessor
            {
                _cost = value;
            }
        }

        public string Currency
        {
            get // get accessor
            {
                return _con;
            }
            set // set accessor
            {
                _con = value;
            }
        }

    }
}
