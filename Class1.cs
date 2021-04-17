using System;

public class Class1 
{
	public Class1()
	{
        
        private string maximo;
    private string cima;
    private string[] lapila;

    public Pilas() { }

    public Pilas(int max)
    {
        lapila = new int[max];
        maximo = max;
        cima = -1;
    }

    public Boolean pila_llena()
    {
        if (cima == maximo - 1)
        { return true; }

        else
        { return false; }

    }

    public Boolean pila_vacia()
    {
        if (cima == -1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void push(string n)
    {
        if (pila_llena() == true)
        {
            MessageBox.Show("Sin espacio para añadir producto");
        }

        else
        {
            cima++; lapila[cima] = n;
        }
    }

    public string pop()
    {
        int n = 0;
        if (pila_vacia() == true)
        {
            MessageBox.Show("Sin Producto");
            return n;
        }

        else
        {
            n = lapila[cima];
            cima--;
            return n;
                 }
              }
           }
        }
	 }
  }
