// Desafio Aula 07 - IMC
// INTEGRANTES DO GRUPO
// Ariel Lisboa
// Anderlany Aragão
// Beatriz Friso
// Isabel Catão
// Laís Baltar

// Questão 1.

Console.WriteLine("Qual sua altura (em m)? ");
double alturaDoUsuario = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Qual seu peso (em kg)? ");
double pesoDoUsuario = Convert.ToDouble(Console.ReadLine());

string retornarDiagnosticoDoUsuario(double alturaDoUsuario, double pesoDoUsuario)
{
    string diagnostico = "";
    double imc;

    imc = pesoDoUsuario / (alturaDoUsuario * alturaDoUsuario);

    if (imc <= 18.5)
    {
        diagnostico = "Anêmico";
    }
    else if (imc > 18.5 && imc <= 25)
    {
        diagnostico = "Normal";
    }
    else if (imc > 25 && imc <= 30)
    {
        diagnostico = "Sobrepeso";
    }
    else if (imc > 30 && imc <= 40)
    {
        diagnostico = "Obesidade";
    }
    else if (imc > 40)
    {
        diagnostico = "Obesidade Grave";
    }

    return diagnostico;
}

Console.WriteLine($"Seu diagnóstico é {retornarDiagnosticoDoUsuario(alturaDoUsuario, pesoDoUsuario)}");






/* ATIVIDADE TEÓRICA:
 * Questão 2. Responda, qual o diagnóstico de um usuário que tenha 1.70 de altura e 105 kg de peso?
Resposta: Obesidade (IMC = 36,33)
 * 
 * 
 * 3. Assinale todas as afirmações que forem verdadeiras, quais as diferenças das condicionais switch e if?

* (V) A instrução if verifica a igualdade e expressão lógica. Por outro lado, o switch verifica apenas a igualdade. 
* (V) A instrução if avalia o tipo inteiro, caractere, ponteiro ou ponto flutuante ou tipo booleano. Por outro lado, a instrução switch avalia apenas um caractere ou um tipo de dados inteiro.
* (F) É possível ter várias instruções com if e switch para múltipla escolha de instruções.
* (V) É possível ter várias instruções if para múltipla escolha de instruções. No switch, você só tem uma expressão para as várias opções.
 * 
 */
