using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Bar {
    internal class Bill {

        private char gender { get; set; }
        private int beer { get; set; }
        private int berbecue { get; set; }
        private int softDrink { get; set; }

        public Bill(char gender, int beer, int berbecue, int softDrink) {
            this.gender = gender;
            this.beer = beer;
            this.berbecue = berbecue;
            this.softDrink = softDrink;
        }

        public double ticket() {
            if (gender == 'F' || gender == 'f') {
                return 8.00;
            }
            return 10.00;
        }
        public double feeding() {
            return (beer * 5) + (softDrink * 3) + (berbecue * 7);
        }

        public double cover() {
            if (feeding() < 30) {
            return 4.00;
            }
            return 0.0;
        }
        public double total() {
            if (feeding() > 30) {
                return feeding() + ticket();
            }
            return feeding() + ticket() + cover();
        }

    }
}
