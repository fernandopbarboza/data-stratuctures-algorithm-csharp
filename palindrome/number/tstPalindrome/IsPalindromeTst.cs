namespace tstPalindrome;
public class IsPalindromeTests
{
    private readonly lbrPalindrome.PalindromeNumber  _solution = new lbrPalindrome.PalindromeNumber();

    [Theory]
    [InlineData(121, true)]    // Palíndromo ímpar
    [InlineData(1221, true)]   // Palíndromo par
    [InlineData(0, true)]      // Caso base zero
    [InlineData(-121, false)]  // Negativo (não é palíndromo)
    [InlineData(10, false)]    // Termina em zero
    [InlineData(123, false)]   // Não é palíndromo
    public void IsPalindrome_CheckVariousInputs_ReturnsExpectedResult(int input, bool expected)
    {
        // Act (Agir)
        bool result = _solution.IsPalindrome(input);

        // Assert (Verificar)
        Assert.Equal(expected, result);
    }

    [Fact]
    public void IsPalindrome_LargePalindrome_ReturnsTrue()
    {
        // Arrange
        int input = 1234565432; 
        // Nota: 12345654321 passaria do limite de 'int' (Int32), 
        // o TDD ajuda a perceber esses limites de overflow!
        
        // Act
        bool result = _solution.IsPalindrome(1234554321);

        // Assert
        Assert.True(result);
    }
}