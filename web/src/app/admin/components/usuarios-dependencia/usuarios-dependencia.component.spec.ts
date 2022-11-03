import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UsuariosDependenciaComponent } from './usuarios-dependencia.component';

describe('UsuariosDependenciaComponent', () => {
  let component: UsuariosDependenciaComponent;
  let fixture: ComponentFixture<UsuariosDependenciaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UsuariosDependenciaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UsuariosDependenciaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
