using System;

namespace CalcularCNPJ
{
    class Program
    {
        static void Main(string[] args)
        {
            string clientecnpj , cnpj1, cnpj2, cnpjfinal;
            int contagem1=12, contagem2=13,resto, rs1=0, rs2=0;
            int[] multiplicador1 = new int[12] {5,4,3,2,9,8,7,6,5,4,3,2};
            int[] multiplicador2 = new int[13] {6,5,4,3,2,9,8,7,6,5,4,3,2};
           // clientecnpj = "16624611000140";
            Console.WriteLine("Digite os numeros  cnpj");
            clientecnpj = (Console.ReadLine());
            cnpj1 = clientecnpj.Substring(0,12);
            

            for(int i=0; i < cnpj1.Length;i++)
        {

        rs1 += int.Parse(cnpj1[i].ToString())*multiplicador1[i];
        contagem1--;
        }
        resto = rs1 % 11;
        if(resto < 2 )
        cnpj2 = cnpj1+0;
        else
        cnpj2 =cnpj1+(11-resto);

        for(int i=0; i < cnpj2.Length;i++)
        {
            rs2 += int.Parse(cnpj2[i].ToString())*multiplicador2[i];
            contagem2--;
        }
        resto = rs2 % 11;
        if(resto < 2 )
        cnpjfinal = cnpj2+0;
        else
        cnpjfinal=cnpj2+(11-resto);
        if(cnpjfinal==clientecnpj)
        {
            Console.WriteLine("O CNPJ é verdadeiro:"+cnpjfinal);
        
        }
        else if(cnpjfinal!=clientecnpj)
        {
            Console.WriteLine("O CNPJ é invalido");

        }

    
        

        


        }
    }
}
