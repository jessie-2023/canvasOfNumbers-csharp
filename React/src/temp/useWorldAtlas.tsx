import { useState, useEffect } from 'react';
import { json } from 'd3';
import { feature, mesh } from 'topojson';
import WorldAtlas from '../models/WorldAtlas';

const jsonUrl = 'https://unpkg.com/world-atlas@2.0.2/countries-50m.json';

export const useWorldAtlas = () => {
  const [data, setData] = useState<WorldAtlas>();
  console.log(data);

  useEffect(() => {
    json(jsonUrl).then(topology => {
      const { countries, interiors } = topology.objects;
      setData({
        countries: feature(topology, countries),
        interiors: mesh(topology, countries, (a, b) => a !== b)
      });
    });
  }, []);
  
  return data;
};
