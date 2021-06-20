const colors = require('tailwindcss/colors');

//Generated with: https://tailwind.ink/ and this hex: #BF233E
const customColors = {
    maroon: {
        '50': '#fcf9f8',
        '100': '#fdeef1',
        '200': '#fbd1e3',
        '300': '#faa9ca',
        '400': '#fb719f',
        '500': '#fc4675',
        '600': '#f62a51',
        '700': '#dc2043',
        '800': '#bf233e',
        '900': '#8c172c',
    },
    mango: {
        '50': '#fcf9f6',
        '100': '#fbf4eb',
        '200': '#f8e3cf',
        '300': '#f4c8a2',
        '400': '#f19b61',
        '500': '#ee7033',
        '600': '#db4b1f',
        '700': '#ae381f',
        '800': '#802c20',
        '900': '#62231d',
    },
    //Here for reference
    orchid: {
        '50': '#faf9fa',
        '100': '#f8f1f8',
        '200': '#f1daf1',
        '300': '#eabaea',
        '400': '#e587de',
        '500': '#de5ace',
        '600': '#c339b2',
        '700': '#922c8c',
        '800': '#682465',
        '900': '#4e1e4d',
    }
}

module.exports = {
    purge: [],
    darkMode: false, // or 'media' or 'class'
    theme: {
        colors: {
            transparent: 'transparent',
            current: 'currentColor',
            black: colors.black,
            white: colors.white,
            gray: colors.coolGray,
            red: colors.red,
            yellow: colors.amber,
            green: colors.emerald,
            blue: colors.blue,
            indigo: colors.indigo,
            purple: colors.violet,
            pink: colors.pink,
        },
        extend: {
            colors: {
                primary: {
                    text: 'white',
                    light: customColors.maroon['200'],
                    DEFAULT: customColors.maroon['800'],
                    dark: customColors.maroon['900']
                },
                secondary: {
                    text: 'white',
                    light: customColors.mango['100'],
                    DEFAULT: customColors.mango['600'],
                    dark: customColors.mango['700']
                },
                success: {
                    text: 'white',
                    light: colors.emerald['100'],
                    DEFAULT: colors.emerald['600'],
                    dark: colors.emerald['700']
                },
                danger: {
                    text: 'white',
                    light: colors.red['200'],
                    DEFAULT: colors.red['600'],
                    dark: colors.red['700']
                },
                info: {
                    text: 'white',
                    light: colors.lightBlue['200'],
                    DEFAULT: colors.lightBlue['500'],
                    dark: colors.lightBlue['700']
                },
                warning: {
                    text: colors.gray['800'],
                    light: colors.amber['200'],
                    DEFAULT: colors.amber['300'],
                    dark: colors.amber['500']
                },
                neutral: {
                    text: colors.gray['100'],
                    light: colors.gray['200'],
                    DEFAULT: colors.gray['700'],
                    dark: colors.gray['800']
                }
            },
            fontFamily: {
                header: ["Montserrat"],
                body: ["Raleway"]
            },
            animation: {
                'fadein-500': "fadeIn 0.5s ease-in forwards",
                'fadein-400': "fadeIn 0.4s ease-in forwards",
                'fadein-300': "fadeIn 0.3s ease-in forwards",
                'fadeout-400': "fadeOut 0.4s ease-out forwards",
                'fadeout-300': "fadeOut 0.3s ease-out forwards",
                'fadeout-200': "fadeOut 0.2s ease-out forwards"
            },
            keyframes: {
                fadeIn: {
                    "0%": { opacity: 0 },
                    "100%": { opacity: 1 }
                },
                fadeOut: {
                    "0%": { opacity: 1 },
                    "100%": { opacity: 0 }
                }
            }
        },
    },
    variants: {
        extend: {},
    },
    plugins: [
        require('@tailwindcss/forms')
    ],
}
