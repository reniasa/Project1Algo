using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class PolynomialsOperations
    {
        public List Addition(List Px, List Qx)
        {
            List Wx = new List();
            Element el = Px.head;

            while(el != null)
            {
                Wx.Add(el.factor, el.index);
                el = el.next;
            }
            el = Qx.head;
            while(el != null)
            {
                if(el.factor == 0)
                {
                    el = el.next;
                }
                Wx.Add(el.factor, el.index);
                el = el.next;
            }
            var Vx = SortAscending(Wx);
            var Cx = CalculateTheSameIndexes(Vx);
            return Cx;
        }

        private List SortAscending(List Wx)
        {
            List Vx = new List();
            Wx.getLenght();
            for (int i = 0; i < Wx.lenght; i++) 
            {
                Element el = Wx.head;
                Element max = null;
                while (el != null && el.next != null)
                {
                    max = el;
                    var current = el.next;
                    if (max.index < current.index)
                    {
                        max = current;
                    }
                    el = el.next;
                }
                if(max != null)
                {
                    Wx.Remove(max.factor, max.index);
                    Vx.Add(max.factor, max.index);
                }
                
            }
                
            
            return Vx;
        }

        private List CalculateTheSameIndexes(List Vx)
        {
            Element el = Vx.head;
            Element newEl = null;
            int newFactor = 0;
            List Calculated = new List();
            Vx.getLenght();
            var lenght = Vx.lenght / 2;
            for (int i = 0; i < lenght; i++)
            {
                newFactor = 0;
                while (el.index == el.next.index)
                {
                    
                    newFactor += el.factor;
                    el = el.next;

                    if (el.next == null)
                    {
                        break;
                    }
                    
                }
                newFactor += el.factor;
                newEl = new Element(newFactor, el.index);
                Calculated.Add(newEl.factor, newEl.index);
                if (el.next != null)
                {
                    el = el.next;
                }
                else
                {
                    break;
                }
                
            }
            return Calculated;
        }
    }
    
}
