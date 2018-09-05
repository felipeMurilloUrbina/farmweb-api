import { Component, OnInit } from '@angular/core';
import { TiposMovimientoService } from '../../_servicios/tipos-movimiento.service';
import { MensajeEstatus } from '../../_modelos/mensaje.enum';

@Component({
  selector: 'app-tipos-movimiento',
  templateUrl: './tipos-movimiento.component.html',
  styleUrls: ['./tipos-movimiento.component.css']
})
export class TiposMovimientoComponent implements OnInit {
  TiposMovimiento: any[];
  cols: any[];
  titulo = 'TiposMovimiento';  
  constructor(public servicio: TiposMovimientoService) { 
        this.cols = [
          { field: 'codigo', header: 'Codigo' },
          { field: 'descripcion', header: 'Descripcion' },
          { field: 'clasificacion', header: 'Clasificacion' },
        ]; 
  }


  ngOnInit() {
    this.get();
  }

  get() {
    this.servicio.getAll(1, 0).subscribe(data => {
      this.TiposMovimiento = data['items'];
    });
  }
}


