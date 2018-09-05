import { Component, OnInit } from '@angular/core';
import { LineaService } from '../../_servicios/linea.service';
import { MensajeEstatus } from '../../_modelos/mensaje.enum';

@Component({
  selector: 'app-linea',
  templateUrl: './linea.component.html',
  styleUrls: ['./linea.component.css']
})
export class LineaComponent implements OnInit {
  Lineas: any[];
  cols: any[];
  titulo = 'Lineas';  
  constructor(public servicio: LineaService) { 
        this.cols = [
        ]; 
  }


  ngOnInit() {
    this.get();
  }

  get() {
    this.servicio.getAll(1, 0).subscribe(data => {
      this.Lineas = data['items'];
    });
  }
}


