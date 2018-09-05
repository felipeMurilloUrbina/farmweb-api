 

import { Component, OnInit } from '@angular/core';
import { AlmacenService } from '../../_servicios/almacen.service';
import { MensajeEstatus } from '../../_modelos/mensaje.enum';

@Component({
  selector: 'app-almacen',
  templateUrl: './almacen.component.html',
  styleUrls: ['./almacen.component.css']
})
export class AlmacenComponent implements OnInit {
  Almacenes: any[];
  cols: any[];
  titulo = 'Almacenes';  
  constructor(public servicio: AlmacenService) { 
        this.cols = [
          { field: 'codigo', header: 'Codigo' },
          { field: 'valorMin', header: 'Valor Minimo' },
          { field: 'valorMax', header: 'Valor Maximo' },
        ]; 
  }


  ngOnInit() {
    this.get();
  }

  get() {
    this.servicio.getAll(1, 0).subscribe(data => {
      this.Almacenes = data['items'];
    });
  }
}


