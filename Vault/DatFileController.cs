﻿using System;
using System.IO;
using System.Collections;
using System.Windows.Forms;

namespace Vault
{
    /*
     * estou neste dia(24/01/17) mudando um pouco a forma com que irei lidar com os dados.
     * pretendo passar a usar o mysql para armazenamento dos dados...
     * uma vez criada a string de conexão e os selects funcionando beleza, tudo será mais facil.  \O/
     *                                                                                             )    (emoticon extremamente bem feito em 04/02/17
     *                                                                                            /\
     * sendo assim, a classe DatFileController ficaria marcada como OBSOLETA, uma vez que não mais utilizaria arquivos DAT para salvamento dos dados.
     * desta forma, estou reformulando o backend.
     */


    class DatFileController
    {
        public ArrayList read(string filePath)
        {
            ArrayList result = new ArrayList();
            try
            {
                StreamReader sr = new StreamReader(filePath);
                string data;
                while ((data = sr.ReadLine()) != null)
                {
                    result.Add(data);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }


            return result;
        } //le o arquivo

        public void print(ArrayList list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        } //print na tela (será mudado para algum tipo de relatório)

        public void append(string filePath, ArrayList list)
        {
            StreamWriter sw = new StreamWriter(filePath, true);
            for (int i = 0; i < list.Count; i++)
            {
                sw.WriteLine(list[i]);
                sw.Flush();
            }
            sw.Close();
        } //adiciona os dados na linha seguinte do arquivo

        public ArrayList search(ArrayList list, String data)
        {
            ArrayList result = new ArrayList();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ToString().Contains(data))
                {
                    result.Add(list[i]);
                }
            }
            return result;
        } //busca e retorna resultados numa Arraylist (buffer)

        public void clean(string file)
        {
            if (MessageBox.Show("Atenção! Esta ação não pode ser desfeita.", "Limpar arquivo de dados?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                new StreamWriter(file, false).Write("");
                MessageBox.Show("Arquivo " + file + " limpo com sucesso.");

            }

        } //limpa o arquivo (será usado como função secreta, perigoso demais, criar uma função de backup para isso antes).

        public void add(string file, ArrayList list)
        {

        } //iria adicionar as linhas já em seu formato específico : necessidade discutivel.
    }
}
