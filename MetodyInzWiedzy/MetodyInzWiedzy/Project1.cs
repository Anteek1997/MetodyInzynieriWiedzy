using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;



namespace MetodyInzWiedzy
{
  public partial class Project1 : UserControl
  {
    public List<List<string>> dane, daneZnormalizowane;
    public List<List<string>> LiczString;
    public List<List<int>> ZliczWarString;
    public List<List<int>> PrzypiszWartosc;


    public Project1()
    {
      InitializeComponent();
    }

    private void Project1_Load(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
      SendToBack();
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    public void button3_Click(object sender, EventArgs e)
    {
      dane = new List<List<string>>(); // Tworzenie listy dwuwymiarowej

      if (openFileDialog1.ShowDialog() == DialogResult.OK)  // sprawdzamy czy plik został wybrany
      {
        dataGridView1.Rows.Clear();  //reset okna
        string filename = openFileDialog1.FileName;
        var table = File.ReadAllLines(filename); // odczytujemy z pliku linijki

        dataGridView1.ColumnCount = table[0].Split(' ', ',', '\t').GetLength(0); // określenie ilości kolumn
        for (int i = 0; i < table.Length; i++)
        {
          dane.Add(new List<string>()); // dodanie elemenru do listy
          DataGridViewRow deklaracja = new DataGridViewRow();  //deklaracja rekordu w grid
          deklaracja.CreateCells(dataGridView1); // tworzenie komórek
          for (int j = 0; j < table[i].Split(' ', ',', '\t').GetLength(0); j++)
          {
            dane[i].Add(table[i].Split(' ', ',', '\t')[j]); // dodawanie danych z plików do listy
            deklaracja.Cells[j].Value = dane[i][j]; // dodawanie danych w celu wyswietlenia
          }

          dataGridView1.Rows.Add(deklaracja); // dodanie Rows
        }

      }

    }

    public void btnSaveXML_Click(object sender, EventArgs e)
    {
      SaveFileDialog saveFileDialog4 = new SaveFileDialog();
      saveFileDialog4.Filter = "xml files (*.xml)|*.xml";
      saveFileDialog4.FilterIndex = 2;
      saveFileDialog4.RestoreDirectory = true;
      saveFileDialog4.OverwritePrompt = true;

      if (saveFileDialog4.ShowDialog() == DialogResult.OK)
      {
        WriteXML2(dane, saveFileDialog4.FileName);
      }

    }
    public void WriteXML2(List<List<string>> dane, string path)
    {
      XmlDocument doc = new XmlDocument();
      XmlElement element1 = doc.CreateElement(string.Empty, "table", string.Empty);
      doc.AppendChild(element1);
      for (int r = 0; r < dane.Count; r++)
      {
        XmlElement element2 = doc.CreateElement(string.Empty, "rec" + r, string.Empty);
        element1.AppendChild(element2);
        for (int c = 0; c < dane[0].Count; c++)
        {
          XmlElement element3 = doc.CreateElement(string.Empty, "atr" + c, string.Empty);
          XmlText text1 = doc.CreateTextNode(dane[r][c]);
          element3.AppendChild(text1);
          element2.AppendChild(element3);

        }
      }
      doc.Save(path);
    }

    private void btnSaveJSON_Click(object sender, EventArgs e)
    {
      
        string json = "";
        json += "{\n";
        const string quote = "\"";
        for (int r = 0; r < dane.Count; r++)
        {
          if (r == 0)
          {
            json += "    " + quote + "r" + quote + ": [\n";
            json += "    " + "{\n";
          }
          else
          {
            json += "    " + "{\n";
          }
          for (int c = 0; c < dane[0].Count; c++)
          {

            if (c == dane[0].Count - 1) //ostatnia kolumna
            {
              if (number(dane, c))
              {
                json += "        " + quote + "a" + c + quote + ": " + dane[r][c] + "\n";
              }
              else
              {
                json += "        " + quote + "a" + c + quote + ": " + quote + dane[r][c] + quote + "\n";
              }
            }
            else
            {
              if (number(dane, c))
              {
                json += "        " + quote + "a" + c + quote + ": " + dane[r][c] + ",\n";
              }
              else
              {
                json += "        " + quote + "a" + c + quote + ": " + quote + dane[r][c] + quote + ",\n";
              }
            }


          }
          if (r == dane.Count - 1)
          {
            json += "    }  ]\n";
          }
          else
          {
            json += "    },\n";
          }

        }
        json += "}\n";
      
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.Filter = "json files (*.json)|*.json";
      saveFileDialog1.FilterIndex = 2;
      saveFileDialog1.RestoreDirectory = true;
      saveFileDialog1.OverwritePrompt = true;

      if (saveFileDialog1.ShowDialog() == DialogResult.OK)
      {
        using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.Create))
        using (StreamWriter sw = new StreamWriter(s))
        {
          sw.Write(json);
        }
      }

    }

    private void btnNext_Click(object sender, EventArgs e)
    {
      project1cz21.BringToFront();
    }
    public bool number(List<List<string>> dane, int arg)
    {
      for (int i = 0; i < dane.Count; i++)
      {
        if (dane[i][arg] != "?")
        {
          if (double.TryParse(dane[i][arg].Replace('.', ','), out var parsedNumber))
          {
            // Jest liczbą
          }
          else
          {
            // Nie jest liczbą
            return false;
          }
        }
      }
      return true;


    }

    private void btnSaveTXT_Click(object sender, EventArgs e)
    {
      string txt= "";
      foreach (var item in dane)
      {
        txt += string.Join(",", item) + "\n";
      }

      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
      saveFileDialog1.FilterIndex = 2;
      saveFileDialog1.RestoreDirectory = true;
      saveFileDialog1.OverwritePrompt = true;

      if (saveFileDialog1.ShowDialog() == DialogResult.OK)
      {
        using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.Create))
        using (StreamWriter sw = new StreamWriter(s))
        {
          sw.Write(txt);
        }
      }
    }

    private void btnNormalizuj_Click(object sender, EventArgs e)
    {

      daneZnormalizowane = dane;
      for (int j = 0; j < dane[0].Count; j++)
      {
        LiczString = new List<List<string>>();
        ZliczWarString = new List<List<int>>();
        PrzypiszWartosc = new List<List<int>>();

        for (int q = 0; q < dane[0].Count; q++)
        {
          LiczString.Add(new List<string>());
          ZliczWarString.Add(new List<int>());
          PrzypiszWartosc.Add(new List<int>());
        }

        if (number(dane, j)) // jeżeli numeryczny 
        {
          double minValue = double.MaxValue; // przypisanie maxymalnej wartości
          double maxValue = double.MinValue; // przypisanie minimalnej wartosci

          for (int i = 0; i < dane.Count; i++)
          {
            Console.WriteLine(dane[i][j] + "..........");
            if (dane[i][j] != "?")
            {
              if (Convert.ToDouble(dane[i][j].Replace(".", ",")) > maxValue) // sprawdzanie wartosci
              {
                maxValue = Convert.ToDouble(dane[i][j].Replace(".", ","));
              }
              if (Convert.ToDouble(dane[i][j].Replace(".", ",")) < minValue)
              {
                minValue = Convert.ToDouble(dane[i][j].Replace(".", ","));
              }
            }

          }
          for (int i = 0; i < dane.Count; i++)
          {
            if (dane[i][j] != "?")
            {
              daneZnormalizowane[i][j] = ((Convert.ToDouble(dane[i][j].Replace(".", ",")) - minValue) / (maxValue - minValue)).ToString(); // normalizacja danych
            }
          }
        }

        else
        {
          //LiczString[j] = new List<string>();
          //ZliczWarString[j] = new List<int>();
          //PrzypiszWartosc[j] = new List<int>();

          for (int i = 0; i < dane.Count; i++)
          {
            
            if (!LiczString[j].Contains(dane[i][j])) // jezeli nie zawiera elementu
            {

              LiczString[j].Add(dane[i][j]); // Tworzenie listy stringów zawarte w atrybucie
              ZliczWarString[j].Add(1); // dane bedą na tych samych indeksach w listach
              Console.WriteLine("xdd");
            }
            else
            {
              int indexElement = 0;
              for (int x = 0; x < LiczString[j].Count; x++)
              {
                if (LiczString[j][x] == dane[i][j])
                {
                  indexElement = x;
                }
              }

              ZliczWarString[j][indexElement]++; // Tworzenie listy stringów dla danego atrybutu
            }
          }
          bool czyZamiana = false;

          do
          {
            czyZamiana = false;
            for (int p = 0; p < ZliczWarString[j].Count - 1; p++)
            {
              if (ZliczWarString[j][p] > ZliczWarString[j][p + 1])
              {
                var tmp = ZliczWarString[j][p];
                ZliczWarString[j][p] = ZliczWarString[j][p + 1];
                ZliczWarString[j][p + 1] = tmp;
                czyZamiana = true;

                var tmp2 = LiczString[j][p];
                LiczString[j][p] = LiczString[j][p + 1];
                LiczString[j][p + 1] = tmp2;

              }
            }
          } while (czyZamiana);  // sortowanie tablicy za pomocą sortowania bombelkowego

          int index = 1;
          bool czy= true;
          for (int k = 0; k < ZliczWarString[j].Count; k++)
          {

            if (LiczString[j][k] == "?")
            {
              index = k;
              czy = false;
            }
          }
          for (int w = 0; w < LiczString[j].Count; w++)
          {

            Console.WriteLine(LiczString[j][w] + " " + ZliczWarString[j][w]);
          }
          if (!czy) {
            LiczString[j].RemoveAt(index);
            ZliczWarString[j].RemoveAt(index);
          }

          for (int w = 0; w < LiczString[j].Count; w++)
          {
            PrzypiszWartosc[j].Add(w + 1);
            //Console.WriteLine(LiczString[j][w] + " " + ZliczWarString[j][w] + " " + PrzypiszWartosc[j][w]);
          }

          double minValue = 1; // przypisanie maxymalnej wartości
          double maxValue = PrzypiszWartosc[j].Last(); // przypisuje wartosci minimalne tablic stringowych

          for (int n = 0; n < dane.Count; n++)
          {
            if (dane[n][j] != "?")
            {
              int Indx = 1;
              for (int k = 0; k < ZliczWarString[j].Count; k++)
              {

                if (LiczString[j][k] == dane[n][j])
                {
                  Indx = k;
                }
              }
              
              double result = (PrzypiszWartosc[j][Indx] - minValue) / (maxValue - minValue);
              if (j==3) { 
              Console.WriteLine(PrzypiszWartosc[j][Indx] + " " + minValue + " " + maxValue + " " + result);
              }
              daneZnormalizowane[n][j] = ((PrzypiszWartosc[j][Indx] - minValue) / (maxValue - minValue)).ToString(); // normalizacja danych
              //Console.WriteLine(PrzypiszWartosc[j][Indx] + " " + minValue + " " + maxValue + " " + result);
            }

          }


        }

        }
      

      dataGridView1.Rows.Clear();

      for (int i = 0; i < daneZnormalizowane.Count; i++)
      {

        DataGridViewRow deklaracja = new DataGridViewRow();  //deklaracja rekordu w grid
        deklaracja.CreateCells(dataGridView1);
        for (int j = 0; j < daneZnormalizowane[0].Count; j++)
        {
          deklaracja.Cells[j].Value = daneZnormalizowane[i][j];
        }
        dataGridView1.Rows.Add(deklaracja);
      }




    }
  }


}


