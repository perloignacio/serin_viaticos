import { Itinerario } from "./Itinerario.model";
import { Ubicaciones } from "./Ubicaciones.model";

export class ItinerarioDetalle{
    IdItinerarioDetalle:number;
    IdItinerario:number;
    IdParada:number;
    UbicacionesEntity:Ubicaciones;
    ItinerarioEntity:Itinerario;
}