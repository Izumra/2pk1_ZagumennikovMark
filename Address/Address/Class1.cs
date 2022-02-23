using System;
using System.Collections.Generic;
using System.Text;
using Address;

namespace Address
{
    class RemoteAddress:Addres
    {
        public string Reason;
        public string reason
        {
            get { return Reason; }
            set
            {
                if (value == "") Reason = "Error.";
                else
                {
                    Reason = value;
                }
            }
        }
        public RemoteAddress(string _reason)
        {
            reason = _reason;
        }
        public RemoteAddress(string _country, string _city, string _street, string _reason) : base(_country, _street,_city)
        {
            reason = _reason;
        }
        public RemoteAddress(int _house, int _flat, string _reason) : base(_house, _flat)
        {
            reason = _reason;
        }
        public RemoteAddress(string _country, string _city, string _street, int _house, int _flat, string _reason): base(_country, _street, _city,_house,_flat)
        {
            reason = _reason;
        }
        new public void GetAddress()
        {
            Console.WriteLine($"Страна проживания:{country} \nГород проживания:{city} \nУлица проживания:{street} \nДом:{house} \nКвартира:{flat} \nПричина удаления адреса из базы:{reason}");
        }
    }
}
