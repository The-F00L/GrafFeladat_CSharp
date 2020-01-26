namespace GrafFeladat_CSharp
{
    /// <summary>
    /// A gráf egy éle, és a hozzá tartozó adatok.
    /// </summary>
    class El
    {
        /// <summary>
        /// Az egyik csúcs indexe
        /// </summary>
        public int Csucs1 { get; private set; }

        /// <summary>
        /// A másik csúcs indexe
        /// </summary>
        public int Csucs2 { get; private set; }

        /// <summary>
        /// Létrehoz egy úgy élt.
        /// </summary>
        /// <param name="csucs1">Az egyik csúcs indexe</param>
        /// <param name="csucs2">A másik csúcs indexe</param>
        public El(int csucs1, int csucs2)
        {
            this.Csucs1 = csucs1;
            this.Csucs2 = csucs2;
        }

        public override string ToString()
        {
            return string.Format("({0} - {1})", Csucs1, Csucs2);
        }
    }
}
