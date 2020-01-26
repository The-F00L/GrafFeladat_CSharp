namespace GrafFeladat_CSharp
{
    /// <summary>
    /// A gráf egy csúcsa, és a hozzá tartozó adatok.
    /// </summary>
    class Csucs
    {
        /// <summary>
        /// A csúcs azonosítója a gráfban
        /// </summary>
        int id;

        /// <summary>
        /// Létrehoz egy új csúcsot a gráfban
        /// </summary>
        /// <param name="id">A csúcs azonosítója a gráfban</param>
        public Csucs(int id)
        {
            this.id = id;
        }

        public override string ToString()
        {
            return this.id.ToString();
        }
    }
}
