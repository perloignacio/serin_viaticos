import { Itinerario } from "./Itinerario.model";
import { Ubicaciones } from "./Ubicaciones.model";

export class ItinerarioDetalle{
    IdItinerarioDetalle:number;
    IdItinerario:number;
    IdOrigen:number;
    IdDestino:number;
    UbicacionesDestinoEntity:Ubicaciones;
    UbicacionesOrigenEntity:Ubicaciones;
    ItinerarioEntity:Itinerario;
}