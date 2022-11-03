import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UsuariosDependenciaFormComponent } from './usuarios-dependencia-form.component';

describe('UsuariosDependenciaFormComponent', () => {
  let component: UsuariosDependenciaFormComponent;
  let fixture: ComponentFixture<UsuariosDependenciaFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UsuariosDependenciaFormComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UsuariosDependenciaFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
