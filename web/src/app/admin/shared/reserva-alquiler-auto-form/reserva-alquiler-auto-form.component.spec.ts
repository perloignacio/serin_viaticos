import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReservaAlquilerAutoFormComponent } from './reserva-alquiler-auto-form.component';

describe('ReservaAlquilerAutoFormComponent', () => {
  let component: ReservaAlquilerAutoFormComponent;
  let fixture: ComponentFixture<ReservaAlquilerAutoFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ReservaAlquilerAutoFormComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ReservaAlquilerAutoFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
