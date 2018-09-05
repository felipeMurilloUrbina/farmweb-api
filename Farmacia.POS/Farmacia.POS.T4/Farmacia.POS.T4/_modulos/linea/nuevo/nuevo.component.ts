import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { FormBuilder, FormGroup, FormControl } from '@angular/forms';
import { LineaService } from '../../../_servicios/linea.service';
import { Linea } from '../../../_modelos/linea.model';
import { MensajeEstatus } from '../../../_modelos/mensaje.enum';

@Component({
  selector: 'app-nuevo-linea',
  templateUrl: './nuevo.component.html',
  styleUrls: ['./nuevo.component.css']
})
export class NuevoLineaComponent implements OnInit {
  Lineas: any[];
  cols: any[];
  titulo = 'Nuevo Linea';
  linea: Linea;
  constructor(private router: Router, private route: ActivatedRoute, private fb: FormBuilder, private servicio: LineaService) {
    this.linea = new Linea();
    this.route.params
      .subscribe(params => {
        if (params['id'] !== undefined) {
            this.linea.id = params['id'];
            this.getId(params['id']);
        }
      });
  }

  ngOnInit() {
    this.get();
  }

  get() {
    if(this.linea.id) {
        this.servicio.getId(this.linea.id).subscribe(data => {
          this.linea = data['item'];
        });
    }
  }
  
  limpiar() {
  }

  regresar() {
    this.router.navigate(['/admin/lineas'], { queryParams: {} });
  }

  validar() {
  }
  
  guardar() {
    this.servicio.post(this.linea, '').subscribe( dato => {
        this.servicio.enviarMensaje(MensajeEstatus.ok, 'Lineas', dato);
        this.limpiar();
    });
  }
}
