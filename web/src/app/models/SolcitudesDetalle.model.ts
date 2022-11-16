import { Itinerario } from "./Itinerario.model";
import { ReservasAereos } from "./ReservasAereo.model";
import { ReservasAlquilerAuto } from "./ReservasAlquilerAuto.model";
import { ReservasHotel } from "./ReservasHotel.model";

export class SolicitudesDetalle{
    IdSolicitudDetalle:number;
    IdSolicitud:number;
    IdSolicitudCategoria:number;
    IdReservaAereo?:number;
    IdReservaHotel?:number;
    IdItinerario?:number;
    IdReservaAlquilerAuto?:number;
    Observaciones:string;
    ReservasAereosEntity?:ReservasAereos;
    ItinerarioEntity?:Itinerario;
    ReservasHotelEntity?:ReservasHotel;
    ReservasAlquilerAutoEntity:ReservasAlquilerAuto;

    
}