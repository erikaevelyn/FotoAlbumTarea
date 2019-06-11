
namespace FotoAlbumTarea{
/*FotoAlbumTarea
Cree una clase "PhotoAlbum" con un atributo privado "numberOfPages".

También debe tener un método público "GetNumberOfPages", que devolverá el número de páginas.

El constructor por defecto creará un álbum con 16 páginas. Habrá un constructor adicional, 
con el que podemos especificar el número de páginas que queremos en el álbum.

Crea una clase "BigPhotoAlbum" cuyo constructor creará un álbum con 64 páginas.
 */
    public class FotoAlbum{

        protected int numeroDePaginas;

        public FotoAlbum(){
            numeroDePaginas = 16;
        }

        public FotoAlbum(int pag){
            numeroDePaginas = pag;
        }

        public int GetNumeroDePaginas(){
            return numeroDePaginas;
        }

    }
}