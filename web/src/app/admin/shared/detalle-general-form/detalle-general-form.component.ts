import { Component, OnInit } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-detalle-general-form',
  templateUrl: './detalle-general-form.component.html',
  styleUrls: ['./detalle-general-form.component.scss']
})
export class DetalleGeneralFormComponent implements OnInit {
  Observaciones:string;
  constructor(private modal:NgbActiveModal) { }

  ngOnInit(): void {
  }

  Guardar(){

  }
  cerrar(){
    this.modal.close();
  }

}
