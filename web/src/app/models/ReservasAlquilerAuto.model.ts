import { Ubicaciones } from "./Ubicaciones.model";

export class ReservasAlquilerAuto{
    IdReservaAlquilerAuto:number;
    IdDestino:number;
    CantPasajeros:number;
    Marca:string;
    Modelo:string;
    FechaDesde:Date;
    FechaHasta:Date;
    Precio?:number;
    UbicacionesEntity:Ubicaciones;
}