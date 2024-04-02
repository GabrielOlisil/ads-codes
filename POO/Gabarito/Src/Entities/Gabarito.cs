namespace Entities;

public class Gabarito
{
  private char[] _alternativasCorretas;


  public Gabarito(char[] alternativasCorretas)
  {
    _alternativasCorretas = alternativasCorretas;
  }

  public char RespostaQuestao(int questao) => _alternativasCorretas[questao];


}
