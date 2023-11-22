namespace Entidades.Interfaces
{
    public interface ISerializacion<T>
    {
        #region METODOS

        /// <summary>
        /// Metodo que se encarga de serializar
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="elemento"></param>
        void ExportarArchivoJson(string ruta, T elemento);

        /// <summary>
        /// Metodo que se encarga de serializar con la opcion para que quede espaciado
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="elemento"></param>
        /// <param name="opcion"></param>
        public void ExportarArchivoJson(string ruta, T elemento, bool opcion);

        /// <summary>
        /// Metodo que se encarga de leer un JSON
        /// </summary>
        /// <param name="ruta"></param>
        /// <returns>el objeto T</returns>
        public T DeserializarArchivoJson(string ruta);
        #endregion
    }
}
