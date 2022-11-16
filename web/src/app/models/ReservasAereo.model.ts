import { Ubicaciones } from "./Ubicaciones.model";

export class ReservasAereos{
    IdOrigen:number;
    IdDestino:number;
    CantPasajeros:number;
    FechaViaje:Date;
    IdaVuelta:boolean;
    Precio?:number;
    UbicacionesDestinoEntity:Ubicaciones;
    UbicacionesOrigenEntity:Ubicaciones;
}