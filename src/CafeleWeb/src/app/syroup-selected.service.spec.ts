import { TestBed } from '@angular/core/testing';

import { SyroupSelectedService } from './syroup-selected.service';

describe('SyroupSelectedService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: SyroupSelectedService = TestBed.get(SyroupSelectedService);
    expect(service).toBeTruthy();
  });
});
