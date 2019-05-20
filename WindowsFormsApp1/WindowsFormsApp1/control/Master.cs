using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Files;

namespace WindowsFormsApp1.control
{
    class Master
    {
        int s = 1;
        int c = 0;
        string done;
        bool special;
        
        public Master()
        {
            c = 0;
            s = 0;
           
        }

        public string Scenery(int _C,int _S)
        {
            c = _C;
            s = _S;

            List_scenes ls = new List_scenes();
            string S=ls.Getscene(s);

            Reader text = new Reader(S);
            Sep sep = new Sep();
            

            done = text.text();
            done = sep.separar(c, done,'#');

            
            if (done == "")
            {
                s++;
                c = 0;
                done = "...";
            }

            Check ch = new Check(done);
           
            special = ch.special();
           

            return done;

        }
        public string Quest()
        {
            Questions Q = new Questions(done);
            if (special == true)
            {
                done = Q.trim(); 
               
            }
            return done;
        }

        public bool GS
        {
            get { return special; }
        }
        
    }
}
