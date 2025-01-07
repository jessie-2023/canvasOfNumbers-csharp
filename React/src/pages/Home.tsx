import { useEffect, useRef, useState} from "react";
import Gap from "../models/Gap";
import { Bar, getElementAtEvent } from "react-chartjs-2";
import {
  Chart as ChartJS,
  CategoryScale,
  LinearScale,
  BarElement,
  Title,
  Tooltip,
  Legend,
  TooltipItem,
} from "chart.js";
import { useNavigate } from "react-router-dom";

// Register the required components for Chart.js
ChartJS.register(CategoryScale, LinearScale, BarElement, Title, Tooltip, Legend);

interface ChartData
{
    labels: string[], // Default empty array for labels
    datasets: {
        label: string,
        data: number[], // Default empty array for dataset values
        backgroundColor: string,
        borderColor: string,
        borderWidth: number,
        hoverBackgroundColor: string,
      }[],
}

export default function Home()
{
    const [chartData, setChartData] = useState<ChartData>({
        labels: [],
        datasets: [
            {
                label: "",
                data: [], 
                backgroundColor: "rgba(75, 192, 192, 0.5)",
                borderColor: "rgba(75, 192, 192, 1)",
                borderWidth: 1,
                hoverBackgroundColor: "rgba(255, 99, 132, 0.5)",               
            },
        ],
    });
    const [countryIds, setCountryIds] = useState<number[]>([]);
    const [loading, setLoading] = useState<boolean>(true);
    const [error, setError] = useState<boolean>(false);

    const chartRef = useRef(null);

    const navigate = useNavigate();

    useEffect(() => {
        fetch(`http://localhost:5287/gender-gap/general/2019`)
        .then(response => response.json())
        .then(data => {
            const countries = data.map((item: Gap) => item.countryName);
            const generalGaps = data.map((item: Gap) => item.generalGap);
            const ids = data.map((item: Gap) => item.countryId);

            setChartData({
                labels: countries,
                datasets: [{
                    label: "General Index (2019)",
                    data: generalGaps,
                    backgroundColor: "rgba(75, 192, 192, 0.5)",
                    borderColor: "rgba(75, 192, 192, 1)",
                    borderWidth: 1,
                    hoverBackgroundColor: "rgba(255, 99, 132, 0.5)",      
                },],
            });
            setCountryIds(ids);
            setLoading(false);
        })
        .catch(() => setError(true))
    }, []);

    
    const handleBarClick = (event: React.MouseEvent<HTMLCanvasElement, MouseEvent>) => {
        const chart = chartRef.current;
        if (chart) {
            const elements = getElementAtEvent(chart, event);

            if (elements.length > 0) {
                const clickedBar = elements[0].index;
                const countryId = countryIds[clickedBar];
                console.log("clicked");
                navigate(`/gender-gap/country/${countryId}`);
            }     
        }
    }

    const chartOptions = {
        responsive:true,
        plugins: {
            legend: {
                position: "top" as const,
            },
            title: {
                display: true,
                text: "General Index",
            },
            tooltip: {
                callbacks: {
                    label: (tooltipItem: TooltipItem<"bar">) => {
                        const label = tooltipItem.dataset.label || "";
                        const value = tooltipItem.raw as number;
                        return `${label} Index: ${value}`;
                    }
                }
            },
        },
    };

    
    if (loading) return <p>Loading...</p>;
    if (error) return <p>Error loading data.</p>;

    return (
        <div>
            <h3>General Index for 2019</h3>
            <Bar
                ref={chartRef}
                data={chartData}
                options={chartOptions}
                onClick={handleBarClick}
            />
        </div>
    )
}