import { Component, OnInit } from '@angular/core';
import { GruposService } from '../../_servicios/grupos.service';
import { MensajeEstatus } from '../../_modelos/mensaje.enum';

@Component({
  selector: 'app-grupos',
  templateUrl: './grupos.component.html',
  styleUrls: ['./grupos.component.css']
})
export class GruposComponent implements OnInit {
  Grupos: any[];
  cols: any[];
  titulo = 'Grupos';  
  constructor(public servicio: GruposService) { 
        this.cols = [
          { field: 'codigo', header: 'Codigo' },
          { field: 'descripcion', header: 'Descripcion' },
        ]; 
  }


  ngOnInit() {
    this.get();
  }

  get() {
    this.servicio.getAll(1, 0).subscribe(data => {
      this.Grupos = data['items'];
    });
  }
}


