import { Hoteles } from "./Hoteles.model";
import { Ubicaciones } from "./Ubicaciones.model";

export class ReservasHotel{
    IdReservaHotel:number;
    IdDestino:number;
    CantHabitaciones:number;
    CantPasajeros:number;
    IdHotel:number;
    CodigoReserva?:string;
    Precio?:number;
    Checkin:Date;
    Checkout:Date;
    HotelesEntity:Hoteles;
    UbicacionesEntity:Ubicaciones;
    
}