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
            List Wx = GlueExpressions(Px, Qx);
            List firstArgument = new List();
            firstArgument.Add(0, -1);
            var sortedExpressions = SortAscending(Wx);
            var shortedExpressions = CalculateTheSameIndexes(sortedExpressions);
            var result = GlueExpressions(firstArgument, shortedExpressions);
            return result;
        }

        public List Substraction(List Px, List Qx)
        {
            List firstArgument = new List();
            firstArgument.Add(0, -1);

            Element el = Qx.head;
            List QxCopy = new List();
            while(el != null)
            {
                Element newEl = new Element(el.factor * -1, el.index);
                QxCopy.Add(newEl.factor, newEl.index);
                el = el.next;
            }
            List Wx = GlueExpressions(Px, QxCopy);
            var sortedExpressions = SortAscending(Wx);
            var shortedExpressions = CalculateTheSameIndexes(sortedExpressions);
            var result = GlueExpressions(firstArgument, shortedExpressions);
            return result;
        }

        public List Multiplication(List Px, List Qx)
        {
            List firstArgument = new List();
            firstArgument.Add(0, -1);

            List multiplyResult = new List();
            Element pxEl = Px.head;
            Element qxEl = Qx.head;
            Px.GetLenght();
            Qx.GetLenght();
            for(int i = 0; i < Px.lenght; i++)
            {
                if(pxEl.factor != 0)
                {
                    for(int j = 0; j < Qx.lenght; j++)
                    {
                        if(qxEl.factor != 0)
                        {
                            var factor = pxEl.factor * qxEl.factor;
                            var index = pxEl.index + qxEl.index;
                            multiplyResult.Add(factor, index);
                            
                        }
                        qxEl = qxEl.next;
                    }

                }
                pxEl = pxEl.next;
                qxEl = Qx.head;
            }
            var sortedResult = SortAscending(multiplyResult);
            var shortedExpressions = CalculateTheSameIndexes(sortedResult);
            var result = GlueExpressions(firstArgument, shortedExpressions);
            return result;
        }

        private static List GlueExpressions(List Px, List Qx)
        {
            List Wx = new List();
            Element el = Px.head;

            while (el != null)
            {
                Wx.Add(el.factor, el.index);
                el = el.next;
            }
            el = Qx.head;
            while (el != null)
            {
                if (el.factor == 0 && el.index == -1)
                {
                    el = el.next;
                }
                Wx.Add(el.factor, el.index);
                el = el.next;
            }

            return Wx;
        }

        private List SortAscending(List Wx)
        {
            List Vx = new List();
            int lastIndex = 0;
            Wx.GetLenght();
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
                if(el == Wx.tail && lastIndex == el.index && max == null)
                {
                    Vx.Add(el.factor, el.index);
                }
                if(max != null)
                {
                    Wx.Remove(max.factor, max.index);
                    Vx.Add(max.factor, max.index);
                    lastIndex = max.index;
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
            Vx.GetLenght();
            var lenght = Vx.lenght / 2;
            for(;;)
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
