import { Component, OnInit } from '@angular/core';
import { ClienteService } from '../../_servicios/cliente.service';
import { MensajeEstatus } from '../../_modelos/mensaje.enum';

@Component({
  selector: 'app-cliente',
  templateUrl: './cliente.component.html',
  styleUrls: ['./cliente.component.css']
})
export class ClienteComponent implements OnInit {
  Clientes: any[];
  cols: any[];
  titulo = 'Clientes';  
  constructor(public servicio: ClienteService) { 
        this.cols = [
          { field: 'descripcion', header: 'Descripcion' },
          { field: 'calle', header: 'Calle' },
          { field: 'codigoPostal', header: 'Codigo Postal' },
          { field: 'rfc', header: 'RFC' },
          { field: 'fecha', header: 'Fecha' },
        ]; 
  }


  ngOnInit() {
    this.get();
  }

  get() {
    this.servicio.getAll(1, 0).subscribe(data => {
      this.Clientes = data['items'];
    });
  }
}


