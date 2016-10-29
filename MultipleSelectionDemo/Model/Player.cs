namespace MultipleSelectionDemo.Model
{
    public class Player
    {
        /// <summary>
        /// Nombre del jugador
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Número de camiseta.
        /// </summary>
        public int Number{ get; set; }

        /// <summary>
        /// Nombre del fichero de la imagen para este jugador.
        /// </summary>
        public string PictureName { get; set; }

        public string PictureSource => "/Assets/Images/" + PictureName;
    }
}
