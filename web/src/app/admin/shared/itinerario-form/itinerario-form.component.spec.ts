import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ItinerarioFormComponent } from './itinerario-form.component';

describe('ItinerarioFormComponent', () => {
  let component: ItinerarioFormComponent;
  let fixture: ComponentFixture<ItinerarioFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ItinerarioFormComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ItinerarioFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
