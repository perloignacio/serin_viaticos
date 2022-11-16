import { ItinerarioDetalle } from "./ItinerarioDetalle.model";

export class Itinerario{
    IdItinerario:number;
    Fecha:Date;
    IdaVuelta:boolean;
    Detalle:ItinerarioDetalle[]=[];
}