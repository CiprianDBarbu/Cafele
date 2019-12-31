import { TestBed } from '@angular/core/testing';

import { CoffeeSelectedService } from './coffee-selected.service';

describe('CoffeeSelectedService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: CoffeeSelectedService = TestBed.get(CoffeeSelectedService);
    expect(service).toBeTruthy();
  });
});
