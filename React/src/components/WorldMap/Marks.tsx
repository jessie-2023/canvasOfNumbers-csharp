import { geoNaturalEarth1, geoPath, geoGraticule } from 'd3';
import WorldAltas from '../../models/WorldAtlas';
import { useMemo } from 'react';


const projection = geoNaturalEarth1();
const path = geoPath(projection);
const graticule = geoGraticule();


export const Marks = ({ data }: { data: WorldAltas }) => 
{

  return (
  <g className="marks">
    {useMemo(
      () => (
        <>
          <path className="sphere" d={path({ type: 'Sphere' }) as string} />
          <path className="graticules" d={path(graticule()) as string} />
          {data.countries.features.map(feature => (
            <path className="land" d={path(feature) as string} />
          ))}
          <path className="interiors" d={path(data.interiors) as string} />
        </>
      ),
      [data.countries.features, data.interiors]
    )}
  </g>

);
}
