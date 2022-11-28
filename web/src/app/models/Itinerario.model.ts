import { ItinerarioDetalle } from "./ItinerarioDetalle.model";

export class Itinerario{
    IdItinerario:number;
    Fecha:Date;
    IdaVuelta:boolean;
    Detalle:ItinerarioDetalle[]=[];
    FechaVuelta:Date;
    Km:number;

    public getKm():number{
        if(this.IdaVuelta){
            return this.Km*2;
        }else{
           return this.Km;
        }
    }
}