using System;

namespace BracketTest
{

    class StackNode
    {
        char data;
        StackNode link;
        public void GetItem(char data)
        {
            this.data = data;
        }

        public void GetLink(StackNode link)
        {
            this.link = link;
        }

        public char showdata()
        {
            return data;
        }
        public StackNode showlink()
        {
            return link;
        }

    }

    class LinkedStack
    {
        private StackNode top;
        public Boolean isEmpty()
        {
            return (top == null);
        }

        public void push(char item)
        {
            StackNode newNode = new StackNode();
            newNode.GetItem(item);
            newNode.GetLink(top);
            top = newNode;
        }

        public char pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Deleting fail! Linked Stack is empty!!");
                return (char)0;
            }
            else
            {
                char item = top.showdata();
                top = top.showlink();
                return item;
            }
        }

        public void delete()
        {
            if (isEmpty())
            {
                Console.WriteLine("Deleting fail! Linked Stack is empty!!");
            }
            else
            {
                top = top.showlink();
            }
        }
        public char peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("Peeking fail! Linked Stack is empty!!");
                return (char)0;
            }
            else
                return top.showdata();
        }

        public void printStack()
        {
            if (isEmpty())
                Console.WriteLine("Linked Stack is empty!!");

        else
            {
                StackNode temp = top;
                Console.WriteLine("Linked Stack>> ");
                while (temp != null)
                {
                    Console.WriteLine("\t"+ temp.showdata()+"\n");
                    temp = temp.showlink();
                }
                Console.WriteLine();
            }
        }


    }

    public class OptExp {
        private String exp;
        private int expSize;
        private char testCh, openPair;

        public Boolean testPair(String exp)
        {
            this.exp = exp;
            LinkedStack s = new LinkedStack();
            expSize = this.exp.Length;
            for (int i = 0; i < expSize; i++)
            {
                testCh = this.exp[i];
                switch (testCh)
                {
                    case '(':
                    case '{':
                    case '[':
                        s.push(testCh);
                        break;
                    case ')':
                    case '}':
                    case ']':
                        if (s.isEmpty())
                            return false;
                        else
                        {
                            openPair = s.pop();
                            if ((openPair == '(' && testCh != ')') || (openPair == '{' && testCh != '}')
                                    || (openPair == '[' && testCh != ']'))
                                return false;
                            else
                                break;
                        }
                }
            }
            if (s.isEmpty())
                return true;
            else
                return false;
        }

        }
    class Program
    { 



        static void Main(string[] args)
 
        {
            OptExp opt = new OptExp();
            String exp = "(3*5)-6/2)";

            Console.WriteLine(exp);

            if (opt.testPair(exp))
                Console.WriteLine("괄호 맞음!!"); 
        else
                Console.WriteLine("괄호 틀림!!");
        }
    }
}