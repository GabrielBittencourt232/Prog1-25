namespace CheckMachine.Models
{
    public class NumeroModel
    {
        public int Number { get; set; }
        public string NumberInWords => ConvertToWords(Number);


    }
}
