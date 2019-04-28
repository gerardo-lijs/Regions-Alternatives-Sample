namespace RegionVersusPartialClass
{
    /// <summary>
    /// This is just a demo to show regions versus partial for cases where the 
    /// class can't be split in separate classes with Single responsibility principle (SRP).
    /// Many people will argue it's always possible to separete and I agree with them.
    /// </summary>
    class RegionClass
    {

        #region Database
        public void LoadDB() { }
        public void SaveDB() { }
        #endregion

        #region File
        public void LoadFile() { }
        public void SaveFile() { }
        #endregion

        #region Language
        public string Word1 { get; }
        public string Word2 { get; }
        #endregion
    }
}
