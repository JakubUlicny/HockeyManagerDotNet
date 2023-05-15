namespace HockeyManager
{
    internal class WrongFormatException : Exception
    {
        public WrongFormatException() : base("The file is in wrong format") { }
    }
}
