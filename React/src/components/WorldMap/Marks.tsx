import { geoNaturalEarth1, geoPath, geoGraticule } from 'd3';
import WorldAltas from '../../models/WorldAtlas';
import { useMemo } from 'react';


const projection = geoNaturalEarth1();
const path = geoPath(projection);
const graticule = geoGraticule();
const missingDataColor = 'lightgray';

export const Marks = ({ 
  world: { countries, interiors },
  mapByCountry,
  colorScale,
  colorValue
}) =>  (
  <g className="marks">
    {useMemo(
      () => (
        <>
          <path className="sphere" d={path({ type: 'Sphere' }) as string} />
          <path className="graticules" d={path(graticule()) as string} />
          {countries.features.map(feature => {

            const country = mapByCountry.get(Number(feature.id));

            return (
            <path className="land" 
              fill={country ? colorScale(colorValue(country)) : missingDataColor}
              d={path(feature) as string} 
            />
          )
          
          })}
          <path className="interiors" d={path(interiors) as string} />
        </>
      ),
      [ countries, interiors,
        mapByCountry,
        colorScale,
        colorValue]
    )}
  </g>

);

