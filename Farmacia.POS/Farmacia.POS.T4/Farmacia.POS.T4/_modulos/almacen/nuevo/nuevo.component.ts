 

import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { FormBuilder, FormGroup, FormControl } from '@angular/forms';
import { AlmacenService } from '../../../_servicios/almacen.service';
import { Almacen } from '../../../_modelos/almacen.model';
import { MensajeEstatus } from '../../../_modelos/mensaje.enum';

@Component({
  selector: 'app-nuevo-almacen',
  templateUrl: './nuevo.component.html',
  styleUrls: ['./nuevo.component.css']
})
export class NuevoAlmacenComponent implements OnInit {
  Almacenes: any[];
  cols: any[];
  titulo = 'Nuevo Almacen';
  almacen: Almacen;
  constructor(private router: Router, private route: ActivatedRoute, private fb: FormBuilder, private servicio: AlmacenService) {
    this.almacen = new Almacen();
    this.route.params
      .subscribe(params => {
        if (params['id'] !== undefined) {
            this.almacen.id = params['id'];
            this.getId(params['id']);
        }
      });
  }

  ngOnInit() {
    this.get();
  }

  get() {
    if(this.almacen.id) {
        this.servicio.getId(this.almacen.id).subscribe(data => {
          this.almacen = data['item'];
        });
    }
  }
  
  limpiar() {
  }

  regresar() {
    this.router.navigate(['/admin/almacenes'], { queryParams: {} });
  }

  validar() {
  }
  
  guardar() {
    this.servicio.post(this.almacen, '').subscribe( dato => {
        this.servicio.enviarMensaje(MensajeEstatus.ok, 'Almacenes', dato);
        this.limpiar();
    });
  }
}
