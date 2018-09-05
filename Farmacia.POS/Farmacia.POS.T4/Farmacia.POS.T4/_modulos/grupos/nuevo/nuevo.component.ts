import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { FormBuilder, FormGroup, FormControl } from '@angular/forms';
import { GruposService } from '../../../_servicios/grupos.service';
import { Grupos } from '../../../_modelos/grupos.model';
import { MensajeEstatus } from '../../../_modelos/mensaje.enum';

@Component({
  selector: 'app-nuevo-grupos',
  templateUrl: './nuevo.component.html',
  styleUrls: ['./nuevo.component.css']
})
export class NuevoGruposComponent implements OnInit {
  Grupos: any[];
  cols: any[];
  titulo = 'Nuevo Grupos';
  grupos: Grupos;
  constructor(private router: Router, private route: ActivatedRoute, private fb: FormBuilder, private servicio: GruposService) {
    this.grupos = new Grupos();
    this.route.params
      .subscribe(params => {
        if (params['id'] !== undefined) {
            this.grupos.id = params['id'];
            this.getId(params['id']);
        }
      });
  }

  ngOnInit() {
    this.get();
  }

  get() {
    if(this.grupos.id) {
        this.servicio.getId(this.grupos.id).subscribe(data => {
          this.grupos = data['item'];
        });
    }
  }
  
  limpiar() {
  }

  regresar() {
    this.router.navigate(['/admin/grupos'], { queryParams: {} });
  }

  validar() {
  }
  
  guardar() {
    this.servicio.post(this.grupos, '').subscribe( dato => {
        this.servicio.enviarMensaje(MensajeEstatus.ok, 'Grupos', dato);
        this.limpiar();
    });
  }
}
