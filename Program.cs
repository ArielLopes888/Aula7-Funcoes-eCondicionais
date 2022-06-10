// Cotação do dólar no dia 3 de maio de 2022.
double cotacaoDoDolarHoje = 4.97;
const double VALOR_MINIMO_DE_COMPRA_EM_DOLAR = 100;
const double VALOR_MAXIMO_DE_COMPRA_EM_DOLAR = 2500;

string converterRealParaDolar(double valorDaCompraEmReais)
{
    double valorConvertido = valorDaCompraEmReais / cotacaoDoDolarHoje;
    string mensagem = "";
    if (valorConvertido < VALOR_MINIMO_DE_COMPRA_EM_DOLAR)
        {
        mensagem = $" A compra mínima permitida é de ${VALOR_MINIMO_DE_COMPRA_EM_DOLAR}";
    }
    else if (valorConvertido > VALOR_MAXIMO_DE_COMPRA_EM_DOLAR)
        {
        mensagem = $" A compra máxima permitida é de ${VALOR_MAXIMO_DE_COMPRA_EM_DOLAR}";
    }
    else
    {
        mensagem = $"Você pode comprar ${valorConvertido}";
    }
    return mensagem;
}


// Utilize as mensagens a seguir como base do retorno esperado:
// A compra mínima permitida é de $ XXX,XX.
// A compra máxima permitida é de $ XXXX,XX.
// Você pode comprar $ XXX,XX.
Console.WriteLine(converterRealParaDolar(10.00));

//PARTE TEÓRICA MA MESA DE TRABALHO
//1. Com base no código, calcule a conversão do real para dólar, 
//estabeleça um valor mínimo e máximo para compra na transação.
//R:Segundo o código acima, o valor de compra mínima é de 100 dólares

//2. Responda, quais recursos foram utilizados para resolução desse problema?
//R: Operadores, variáveis, constantes, funções, parâmetros e retorno de função.

//3. Responda, quais tipos de variável é retornada  pela função nessa atividade?
//R: string
