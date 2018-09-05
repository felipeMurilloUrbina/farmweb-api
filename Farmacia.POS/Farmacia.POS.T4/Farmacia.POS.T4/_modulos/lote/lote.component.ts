import { Component, OnInit } from '@angular/core';
import { LoteService } from '../../_servicios/lote.service';
import { MensajeEstatus } from '../../_modelos/mensaje.enum';

@Component({
  selector: 'app-lote',
  templateUrl: './lote.component.html',
  styleUrls: ['./lote.component.css']
})
export class LoteComponent implements OnInit {
  Lotes: any[];
  cols: any[];
  titulo = 'Lotes';  
  constructor(public servicio: LoteService) { 
        this.cols = [
          { field: 'codigo', header: 'Codigo' },
          { field: 'descripcion', header: 'Descripcion' },
          { field: 'fecha', header: 'Fecha' },
        ]; 
  }


  ngOnInit() {
    this.get();
  }

  get() {
    this.servicio.getAll(1, 0).subscribe(data => {
      this.Lotes = data['items'];
    });
  }
}


