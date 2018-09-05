import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { FormBuilder, FormGroup, FormControl } from '@angular/forms';
import { LoteService } from '../../../_servicios/lote.service';
import { Lote } from '../../../_modelos/lote.model';
import { MensajeEstatus } from '../../../_modelos/mensaje.enum';

@Component({
  selector: 'app-nuevo-lote',
  templateUrl: './nuevo.component.html',
  styleUrls: ['./nuevo.component.css']
})
export class NuevoLoteComponent implements OnInit {
  Lotes: any[];
  cols: any[];
  titulo = 'Nuevo Lote';
  lote: Lote;
  constructor(private router: Router, private route: ActivatedRoute, private fb: FormBuilder, private servicio: LoteService) {
    this.lote = new Lote();
    this.route.params
      .subscribe(params => {
        if (params['id'] !== undefined) {
            this.lote.id = params['id'];
            this.getId(params['id']);
        }
      });
  }

  ngOnInit() {
    this.get();
  }

  get() {
    if(this.lote.id) {
        this.servicio.getId(this.lote.id).subscribe(data => {
          this.lote = data['item'];
        });
    }
  }
  
  limpiar() {
  }

  regresar() {
    this.router.navigate(['/admin/lotes'], { queryParams: {} });
  }

  validar() {
  }
  
  guardar() {
    this.servicio.post(this.lote, '').subscribe( dato => {
        this.servicio.enviarMensaje(MensajeEstatus.ok, 'Lotes', dato);
        this.limpiar();
    });
  }
}
