using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Collections;
using System.ComponentModel;

namespace Bootstrap.Model {
    public class Bayiler {
        public int id { get; set; }
        public string bayiAdi { get; set; }
        public int bayiCirosu { get; set; }
        public string gun { get; set; }

        public Bayiler(int id, string bayiAdi, int bayiCirosu, string gun) {
            this.id = id;
            this.bayiAdi = bayiAdi;
            this.bayiCirosu = bayiCirosu;
            this.gun = gun;

        }

       

        public ArrayList GetList() {
            ArrayList list = new ArrayList();
            list.Add(new Bayiler(1, "Fikret", 50, "pazar"));
            list.Add(new Bayiler(2, "Kelkit", 50, "perşembe"));
            list.Add(new Bayiler(3, "Zengin", 50, "pazartesi"));
            list.Add(new Bayiler(4, "Uzn", 50, "salı"));
            list.Add(new Bayiler(5, "Anafarta", 50, "çarsamba"));
           
            return list;
        }
       
        
    }

    
}